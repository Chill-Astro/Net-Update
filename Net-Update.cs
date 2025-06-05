using System.Net.Http;
using System;

namespace NetUpdate
{
    public static class NetUpdate
    {
        private static readonly HttpClient client = new HttpClient();
        static void update(string appName, string appVer, string rawGistURL)
        {
            try
            {
                client.Timeout = TimeSpan.FromSeconds(5);
                HttpResponseMessage response = client.GetAsync(rawGistURL).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                string latestVersion = response.Content.ReadAsStringAsync().GetAwaiter().GetResult().Trim();
                Version current = new Version(appVer);
                Version latest = new Version(latestVersion);

                if (latest.CompareTo(current) > 0)
                {
                    Console.WriteLine($"Woohoo! A NEW version of {appName} is Available!\n");                    
                }
                else if (latest.CompareTo(current) == 0)
                {
                    Console.WriteLine($"Hurrah! {appName} is up to date!\n");
                }
                else
                {
                    Console.WriteLine("WARNING! This appears to be a DEV. Build.\n");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Could not check for updates. Please check your internet connection.");
                Console.WriteLine($"Error: {e.Message}\n");
            }
            catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
            {
                Console.WriteLine("Update check timed out. Please check your internet connection.\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Could not parse the version from the update source.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred during the update check.");
                Console.WriteLine($"Error: {e.Message}\n");
            }
        }
    }
}
