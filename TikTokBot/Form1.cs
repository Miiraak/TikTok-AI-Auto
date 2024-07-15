using System.Text;
using System.Security.Cryptography;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace TikTokBot
{
    public partial class Form1 : Form
    {
        private readonly string clientId = "XXX";
        private readonly string clientSecret = "XXX";
        private readonly string redirectUri = "http://localhost:3455/callback/";
        private string codeVerifier = "";
        private string AccessToken = "";
        private bool hasTokenBeenRetrieved = false;

        public Form1()
        {
            InitializeComponent();
            buttonPublish.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ClientID : {clientId}\nclientSecret : {clientSecret}\nredirectURL : {redirectUri}\nAccess token : {AccessToken}\nCodeVerifier : {codeVerifier}");
        }

        private void ButtonShutdown_Click(object sender, EventArgs e)
        {
            webView2.Dispose();
            this.Close();
        }

        private void ButtonConnection_Click(object sender, EventArgs e)
        {
            if (!hasTokenBeenRetrieved)
            {
                buttonConnection.Visible = false;
                InitializeWebView2Control();
                buttonPublish.Enabled = true;
            }
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            PublishPhotoAsync(AccessToken);
        }

        private async void InitializeWebView2Control()
        {
            webView2 = new()
            {
                Dock = DockStyle.Fill
            };
            webView2.NavigationCompleted += WebView2_NavigationCompleted;

            Controls.Add(webView2);

            codeVerifier = PKCEUtil.GenerateCodeVerifier();
            string codeChallenge = PKCEUtil.GenerateCodeChallenge(codeVerifier);

            string authUrl = $"https://www.tiktok.com/v2/auth/authorize" +
                             $"?client_key={clientId}" +
                             $"&redirect_uri={redirectUri}" +
                             $"&response_type=code" +
                             $"&scope=user.info.basic,video.publish" +
                             $"&code_challenge={codeChallenge}" +
                             $"&code_challenge_method=S256";

            await webView2.EnsureCoreWebView2Async();
            webView2.CoreWebView2.Navigate(authUrl);
        }

        private async void WebView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            var url = webView2.CoreWebView2.Source;

            if (url.StartsWith(redirectUri))
            {
                var queryParams = new Uri(url).Query;
                var code = System.Web.HttpUtility.ParseQueryString(queryParams).Get("code");

                if (!string.IsNullOrEmpty(code))
                {
                    await ExchangeCodeForTokenAsync(code);
                }
            }
        }

        private async Task ExchangeCodeForTokenAsync(string authorizationCode)
        {
            using var client = new HttpClient();
            var tokenEndpoint = "https://open.tiktokapis.com/v2/oauth/token/";
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("client_key", clientId),
                new KeyValuePair<string, string>("client_secret", clientSecret),
                new KeyValuePair<string, string>("code", authorizationCode),
                new KeyValuePair<string, string>("grant_type", "authorization_code"),
                new KeyValuePair<string, string>("redirect_uri", redirectUri),
                new KeyValuePair<string, string>("code_verifier", codeVerifier)
            });

            var response = await client.PostAsync(tokenEndpoint, content);

            var responseContent = await response.Content.ReadAsStringAsync();
            var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(responseContent);
            var accessToken = tokenResponse?.Access_token;

            if (accessToken == null)
            {
                MessageBox.Show($"Failed to get access token. Response: {responseContent}");
                return;
            }
            else
            {
                AccessToken = accessToken;
                hasTokenBeenRetrieved = true;

                await GetUserProfileAsync(accessToken);
                webView2.Visible = false;
            }
        }

        public class TokenResponse
        {
            public string Access_token { get; set; }
        }

        private async Task GetUserProfileAsync(string accessToken)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var profileEndpoint = "https://open.tiktokapis.com/v2/user/info/?fields=open_id,union_id,avatar_url,display_name";
            var response = await client.GetAsync(profileEndpoint);
            var responseContent = await response.Content.ReadAsStringAsync();

            var userProfileResponse = JsonConvert.DeserializeObject<UserProfileResponse>(responseContent);
            var displayName = userProfileResponse?.Data?.User?.Display_name;

            if (displayName != null)
            {
                textBoxUsername.Text = displayName;
            }
            else
            {
                MessageBox.Show($"Failed to get user profile. Response: {responseContent}");
            }
        }

        public class UserProfileResponse
        {
            public UserProfileData Data { get; set; }
        }

        public class UserProfileData
        {
            public UserProfile User { get; set; }
        }

        public class UserProfile
        {
            public string Display_name { get; set; }
        }

        private async Task PublishPhotoAsync(string accessToken)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                    // Définir les informations de la publication
                    var postInfo = new
                    {
                        title = "Test #2",
                        description = "this will be a #funny project on @tiktok",
                        disable_comment = false,
                        privacy_level = "SELF_ONLY",
                        auto_add_music = true
                    };

                    // Définir les informations de la source (pour une photo)
                    var sourceInfo = new
                    {
                        source = "PULL_FROM_URL",
                        photo_cover_index = 0,
                        photo_images = new string[]
                        {
                            "https://[your file url].jpeg"
                        }
                    };

                    // Construire l'objet JSON pour la requête
                    var requestContent = new
                    {
                        post_info = postInfo,
                        source_info = sourceInfo,
                        post_mode = "DIRECT_POST",
                        media_type = "PHOTO"
                    };

                    // Convertir l'objet en JSON
                    var jsonContent = JsonConvert.SerializeObject(requestContent);

                    // Créer une HttpRequestMessage pour spécifier le contenu de la requête
                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Post,
                        RequestUri = new Uri("https://open.tiktokapis.com/v2/post/publish/content/init/"),
                        Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
                    };

                    // Envoyer la requête HTTP
                    var response = await client.SendAsync(request);

                    // Lire la réponse de l'API
                    var responseBody = await response.Content.ReadAsStringAsync();

                    // Vérifiez le code de statut de la réponse
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Photo publiée avec succès sur TikTok.");
                    }
                    else
                    {
                        MessageBox.Show($"Erreur lors de la publication de la photo : {response.StatusCode}, Détails : {responseBody}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la publication de la photo : {ex.Message}");
            }
        }
    }

    public static class PKCEUtil
    {
        public static string GenerateCodeVerifier()
        {
            using var rng = new RNGCryptoServiceProvider();
            var bytes = new byte[32];
            rng.GetBytes(bytes);
            return Base64UrlEncode(bytes);
        }

        public static string GenerateCodeChallenge(string codeVerifier)
        {
            var bytes = Encoding.ASCII.GetBytes(codeVerifier);
            using var sha256 = SHA256.Create();
            var hash = sha256.ComputeHash(bytes);

            return Convert.ToHexString(hash);
        }

        private static string Base64UrlEncode(byte[] input)
        {
            var output = Convert.ToBase64String(input)
                .Replace('+', '-')
                .Replace('/', '_')
                .Replace("=", "");
            return output;
        }
    }
}
