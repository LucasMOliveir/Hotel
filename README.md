# HotelApi — execução local

A API usa ASP.NET Core 8 e pode rodar sem Docker e sem IIS Express.

## Visual Studio

1. Abra `HotelApi.sln`.
2. Se necessário, clique com o botão direito no projeto HotelApi e escolha **Definir como Projeto de Inicialização**.
3. Ao lado do botão de iniciar, selecione o perfil **http**.
4. Pressione **F5** (com depuração) ou **Ctrl+F5** (sem depuração).
5. Acesse http://localhost:5234/weatherforecast para conferir a resposta JSON.

O perfil local selecionado está em `HotelApi/HotelApi.csproj.user`; as portas e os perfis estão em `HotelApi/Properties/launchSettings.json`.

## Terminal

Na pasta que contém `HotelApi.sln`, execute:

```powershell
dotnet run --project .\HotelApi\HotelApi.csproj --launch-profile http
```

Pare a aplicação com **Ctrl+C**. Para compilar pelo terminal, é necessário um SDK .NET compatível com o alvo .NET 8 e o runtime ASP.NET Core 8 instalado.

## HTTPS opcional

Para usar o perfil `https`, confie no certificado de desenvolvimento com `dotnet dev-certs https --trust` e depois execute:

```powershell
dotnet run --project .\HotelApi\HotelApi.csproj --launch-profile https
```

Nesse perfil, acesse https://localhost:7001/weatherforecast.

No perfil HTTP, o middleware de redirecionamento pode informar que não encontrou uma porta HTTPS; isso não impede a resposta HTTP local.

## Docker

Os arquivos de Docker foram preservados para uso futuro. Para rodar localmente, mantenha o perfil **http** ou **https** selecionado, em vez de **Container (Dockerfile)**.

A rota `/` não tem uma página configurada e pode retornar 404. O endpoint de exemplo é `/weatherforecast`; este projeto ainda não configura Swagger.
