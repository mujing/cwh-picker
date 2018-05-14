FROM microsoft/dotnet:latest
ARG source
WORKDIR /app
COPY ${source:-obj/Docker/publish} .
ENTRYPOINT ["dotnet", "CWHPicker.dll"]