# API 

## Como alterar porta da aplicação?

* Navegue até a pasta <i>Properties</i>, lá terá um arquivo JSON com as configurações de nosso projeto.
* Ache a chave que contenha:

    
    "api": {
        "commandName": "Project",
        "dotnetRunMessages": true,
        "launchBrowser": true,
        "applicationUrl": "https://localhost:7245;http://localhost:5147",
        "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
    }

Agora basta alerar a porta em "applicationUri".

<span style="color: #d9de43">Lembrando que as portas no protocolo http e https devem ser diferentes para não haver conflito!</span>

