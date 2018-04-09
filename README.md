# vHackOS-API
vHackOS-API is a Web Api Wrapper for the mobile virtual hacking game vHackOS.

# How to use
The main class you are supposed to work with is called `vhGame`.
From there you have access to several endpoints of the API. 
First you have to obtain your accesstoken by either logging in with the LoginEndpoint
or read it out from your phone (only works with root i think).

From the LoginEndpoint you get back an object of type `LoginCredentials` which contains USER ID and ACCESSTOKEN.
After you have logged in or you have your uid and token from your phone you can call `SetCredentials()` in the `vhGame` class to authenticate the API client. Now you got access to all endpoints. If you want to use your uid and accesstoken from your phone call the static `LoginCredentials.Create` function to generate the object you need to provide to `vhGame.SetCredentials()`.

# Attention
The terms of service from the creator of vHackOS which is called KF-Media Solutions deny using their private Web Api through 3rd Party Software.
This library only gives you the ability to use the Api for whatever reason you can bring up. I am NOT responsible for your account
being suspended from their system when this library was used!
*Additionally* they might initiate judicial measures against you when using their API. 

# License
When using this library you are forced to publish your project which uses this library also under the GPL V3 license which also means you have to publish the source visible for everyone on the internet.
