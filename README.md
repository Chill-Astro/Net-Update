<p align="center">
  <img src="https://github.com/Chill-Astro/Net-Update/blob/main/Net-Update.png" width="540px">
</p>
Net-Update is a readymade set of Python, C# & Java Classes for Easy Implementation of Update Checking in CUI Apps.

---

## Python :

1.  **Download :** Clone or download the `Net_Update.py` file from this repository.
2.  **Include :** Add the `Net_Update.py` file to your Python Project.
3.  **Access Method :** Use the following code to import the class :

    ```Python

    import Net_Update
    appName = "" # Insert App Name here
    appVer = "" # Insert App Version Here
    rawGistURL = "" # Insert Raw Gist URL here
    Net_Update.update(appName,appVer,rawGistURL)

    ```

    
Here appName is the name of your app and gistURL is the public gist being used for update checking.    
CURRENT_VERSION, appName & gistURL are string Variables. Arguments must be in "".

<p align="center">
  ---------------------[ OR ]---------------------
</p>

Copy the code into your class :

    import requests    
    appName = "" # Insert App Name here
    appVer = "" # Insert App Version Here
    rawGistURL = "" # Insert Raw Gist URL here
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
    
    update(appVer, appName, rawGistURL) # Call the update function with the provided parameters    
        
    
Here appName is the name of your app, appVer is it's version and rawGistURL is the public gist being used for update checking.    
Arguments must be in "" as they are String variables!

---

## C# [ .NET ] :

1.  **Download :** Clone or download the `Net_Update.cs` file from this repository.
2.  **Include :** Add the `Net_Update.cs` file to your Solution.
3.  **Add Nuget Package :** System.Net.Http is required to be added to the project.
    ```C#
    dotnet add package System.Net.Http
    ```
4.  **Access Method :** Since the update() method is static, no object creation is needed. Use the following code :  

    ```C#
    Net_Update.update(appName, appVer, rawGistURL);
    ```

Here appName is the name of your app, appVer is it's version and rawGistURL is the public gist being used for update checking.    
Arguments must be in "" as they are String variables!

---

## Java :

1.  **Download :** Clone or download the `Net_Update.java` file from this repository.
2.  **Include :** Add the `Net_Update.java` file to your Java project.
3.  **Access Method :** Since the update() method is static, no object creation is needed. Use the following code :


    ```java
    Net_Update.update(appName, appVer, rawGistURL);
    ```

Here appName is the name of your app, appVer is it's version and rawGistURL is the public gist being used for update checking.    
Arguments must be in "" as they are String variables!

---

## Note from Developer :

Appreciate my effort? Why not leave a Star ⭐ ! Also if forked, please credit me for my effort and thanks if you do! :)

---
