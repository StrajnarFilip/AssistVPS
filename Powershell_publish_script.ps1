dotnet publish --runtime win-x64 `
-p:PublishSingleFile=true `
-p:PublishTrimmed=true `
-p:IncludeAllContentForSelfExtract=true `
--self-contained=true

dotnet publish --runtime win-x86 `
-p:PublishSingleFile=true `
-p:PublishTrimmed=true `
-p:IncludeAllContentForSelfExtract=true `
--self-contained=true

dotnet publish --runtime win-arm64 `
-p:PublishSingleFile=true `
-p:PublishTrimmed=true `
-p:IncludeAllContentForSelfExtract=true `
--self-contained=true

dotnet publish --runtime win-arm `
-p:PublishSingleFile=true `
-p:PublishTrimmed=true `
-p:IncludeAllContentForSelfExtract=true `
--self-contained=true

dotnet publish --runtime linux-x64 `
-p:PublishSingleFile=true `
-p:PublishTrimmed=true `
-p:IncludeAllContentForSelfExtract=true `
--self-contained=true

dotnet publish --runtime linux-musl-x64 `
-p:PublishSingleFile=true `
-p:PublishTrimmed=true `
-p:IncludeAllContentForSelfExtract=true `
--self-contained=true

dotnet publish --runtime linux-arm `
-p:PublishSingleFile=true `
-p:PublishTrimmed=true `
-p:IncludeAllContentForSelfExtract=true `
--self-contained=true

dotnet publish --runtime linux-arm64 `
-p:PublishSingleFile=true `
-p:PublishTrimmed=true `
-p:IncludeAllContentForSelfExtract=true `
--self-contained=true

dotnet publish --runtime rhel-x64 `
-p:PublishSingleFile=true `
-p:PublishTrimmed=true `
-p:IncludeAllContentForSelfExtract=true `
--self-contained=true