#!/usr/bin/env bash
set -e
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -o openapi.yaml https://raw.githubusercontent.com/togethercomputer/openapi/main/openapi.yaml
autosdk generate openapi.yaml \
  --namespace Together \
  --clientClassName TogetherClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations
