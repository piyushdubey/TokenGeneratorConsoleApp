
using Azure.Core;
using Azure.Identity;

// Application / Client Id
string clientId = "";

// Tenant Id
string tenantId = "";

// Client Secret
string clientSecret = "";

// Create a client secret credential
var clientSecretCredential = new ClientSecretCredential(
    tenantId, clientId, clientSecret);

// Get a token for the Storage account
var tokenRequestContext = new TokenRequestContext(new[] { "https://storage.azure.com/.default" });
var accessToken = await clientSecretCredential.GetTokenAsync(tokenRequestContext);

Console.WriteLine($"Access Token: {accessToken.Token}");
 