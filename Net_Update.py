import requests

class UpdateCheck : # Net-Update v1.0 by Chill-Astro
    @staticmethod
    def update(appVer, appName, gistURL) :
        try :
            response = requests.get(gistURL, timeout=5) # Fetch version file, timeout after 5 seconds
            response.raise_for_status()  # Raise an error for bad responses
            newVer = response.text.strip()  # Get the version from the response
            if newVer > appVer :
                print(f"🎉 A NEW version of {appName} is Available! : {newVer}\n")
            elif newVer == appVer :
                print(f"🎉 {appName} is up to date!\n") # Latest Version
            elif newVer < appVer :
                print(f"⚠️  This is a DEV. Build of {appName}!\n") # For development builds, we assume the version is lower
        except requests.RequestException as e:
             print("⚠️  Could not check for updates. Please check your internet connection.\n" f"Error: {e}\n")
        except Exception as e: # Catching other potential errors, like if the content of the file is not proper.
            print("⚠️  Error occurred while checking for updates.\n" f"Error: {e}\n")