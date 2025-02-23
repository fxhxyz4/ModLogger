#!/bin/sh

set -e

echo "🔧 Building the project..."

VERSION_TYPE=$1

if [ -z "$VERSION_TYPE" ]; then
  VERSION_TYPE="net9.0"
fi

dotnet build --framework $VERSION_TYPE

echo "🚀 Build completed for framework ($VERSION_TYPE)..."
echo "✅ Done!"
