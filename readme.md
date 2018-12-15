# tmpps.infrastructure.data

## command

#### build

`dotnet build Tmpps.Infrastructure.Data.Tests/`

#### test

`dotnet test Tmpps.Infrastructure.Data.Tests/`

#### register nuget

```bash
dotnet build -c Release Tmpps.Infrastructure.Data
# replace version,api-key
dotnet pack -c Release --include-source -p:PackageVersion=${version} Tmpps.Infrastructure.Data
dotnet nuget push ./Tmpps.Infrastructure.Data/bin/Release/Tmpps.Infrastructure.Data.${version}.nupkg -k ${api-key} -s https://api.nuget.org/v3/index.json
```

## use circleCI CLI

#### validation config

`circleci config validate`

#### test

`circleci local execute --job test`

#### release

```bash
git tag X.Y.Z
git push origin --tags
```
