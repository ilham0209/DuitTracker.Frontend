#!/bin/sh
curl -sSL https://dot.net/v1/dotnet-install.sh > dotnet-install.sh
chmod +x dotnet-install.sh
./dotnet-install.sh -c 10.0 -InstallDir ./dotnet
./dotnet/dotnet --version
./dotnet/dotnet publish -c Release -o output

# Fix blazor script tag to use type=module with fingerprinted filename
BLAZOR_JS=$(ls output/wwwroot/_framework/blazor.webassembly.*.js | grep -v '\.br$' | grep -v '\.gz$' | head -1 | xargs basename)
echo "Found blazor file: $BLAZOR_JS"
sed -i "s|<script src=\"_framework/blazor.webassembly.js\"></script>|<script type=\"module\" src=\"_framework/$BLAZOR_JS\"></script>|g" output/wwwroot/index.html

# Add _routes.json for SPA routing
cat > output/wwwroot/_routes.json << 'ROUTES'
{
  "version": 1,
  "include": ["/*"],
  "exclude": [
    "/_framework/*",
    "/_content/*",
    "/css/*",
    "/lib/*",
    "/*.png",
    "/*.ico",
    "/*.json",
    "/*.js",
    "/*.css"
  ]
}
ROUTES

echo "Build complete!"