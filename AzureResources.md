azd env set AZURE_FORMRECOGNIZER_RESOURCE_GROUP rg-AzureOpenAISearch
azd env set AZURE_FORMRECOGNIZER_SERVICE cog-di-phdxfsgjsr3hm
azd env set AZURE_SEARCH_SERVICE gptkb-phdxfsgjsr3hm
azd env set AZURE_SEARCH_SERVICE_RESOURCE_GROUP rg-AzureOpenAISearch

az containerapp update -n ca-web-lsdev4oszzfdkhuuvq -g rg-azure-search-openai-demo-csharp --set-env-vars AZURE_SEARCH_SERVICE_ENDPOINT="https://gptkb-phdxfsgjsr3hm.search.windows.net/"


Autenticación Azure
https://learn.microsoft.com/es-mx/azure/container-apps/authentication-entra#--option-1-create-a-new-app-registration-automatically

