# tmpps.infrastructure.data

## register nuget

```bash
npm run publish
# replace version,api-key
dotnet nuget push ./Tmpps.Infrastructure.Data/bin/Release/Tmpps.Infrastructure.Data.${version}.nupkg -k ${api-key} -s https://api.nuget.org/v3/index.json
```