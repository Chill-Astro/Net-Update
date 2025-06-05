<p align="center">
  <img src="https://github.com/Chill-Astro/Net-Update/blob/main/Net-Update.png" width="540px">
</p>
Net-Update is a readymade set of Python, C# & Java Classes for Easy Implementation of Update Checking in CUI Apps.

[ NOTE ] : Net-Update Python is in Development! C# and Java can be aceessed by cloning the main branch.

---

## Python : // Not Ready Yet

1.  **Download :** Clone or download the `NetUpdate.py` file from this repository.
2.  **Include :** Add the `NetUpdate.py` file to your Python Project.
3.  **Access Method :** Use the following code to import the class :

    ```Python
    class <classname> :
    def call(self):
        NetUpdate.update(appName, gistURL)
    ```

    
Here appName is the name of your app and gistURL is the public gist being used for update checking.    
CURRENT_VERSION, appName & gistURL are string Variables. Arguments must be in "".

<p align="center">
  ---------------------[ OR ]---------------------
</p>

Copy the code into your class :

        
    import requests
    gistURL = "" # Insert Raw Gist URL here
    appVer = "" # Insert App Version Here
    appName = "" # Insert App Name here

    def update() :
    try:
        response = requests.get(gistURL, timeout=5) # Fetch version file, timeout after 5 seconds
        response.raise_for_status() # Raise HTTPError for bad responses
        latest_version = response.text.strip() # Get version string from file and remove whitespace
        if latest_version > CURRENT_VERSION:
            print("--- UPDATE AVAILABLE! ---\n"
                  f"🎉 A NEW version of {appname} is Available! : {latest_version}\n"
                  f"Currently using : {CURRENT_VERSION}\n"                  
                  "-----------------------")
        elif latest_version == CURRENT_VERSION:
            print("🎉 {appname} is up to date!\n")
        else:
            print("⚠️  This is a DEV. Build of {appname}!\n") # For development scenarios
    except requests.exceptions.RequestException as e:
        print("--- UPDATE CHECK FAILED! ---\n"
              "⚠️ Could not check for updates. Please check your internet connection.\n"
              f"Error: {e}\n"
              "------------------------")
    except Exception as e: # Catching other potential errors, like if the content of the file is not proper
        print("--- UPDATE CHECK FAILED ---\n"
              "⚠️ Error occurred while checking for updates.\n"
              f"Error: {e}\n"
              "------------------------")
        
    
Here appName is the name of your app, appVer is it's version and rawGistURL is the public gist being used for update checking.    
Arguments must be in "" as they are String variables!

---

## C# [ .NET ] : // OUT NOW!

1.  **Download :** Clone or download the `Net_Update.cs` file from this repository.
2.  **Include :** Add the `Net_Update.cs` file to your Solution.
3.  **Add Nuget Package :** System.Net.Http is required to be added to the project.
    ```C#
    dotnet add package System.Net.Http
    ```
4.  **Access Method :** Since the update() method is static, no object creation is needed. Use the following code :  

    ```C#
    Net-Update.update(appName, appVer, rawGistURL);
    ```

Here appName is the name of your app, appVer is it's version and rawGistURL is the public gist being used for update checking.    
Arguments must be in "" as they are String variables!

---

## Java : // OUT NOW!

1.  **Download :** Clone or download the `Net_Update.java` file from this repository.
2.  **Include :** Add the `Net_Update.java` file to your Java project.
3.  **Access Method :** Since the update() method is static, no object creation is needed. Use the following code :


    ```java
    Net_Update.update(appName, appVer, rawGistURL);
    ```

Here appName is the name of your app, appVer is it's version and rawGistURL is the public gist being used for update checking.    
Arguments must be in "" as they are String variables!
