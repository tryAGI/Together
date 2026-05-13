#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://docs.together.ai/openapi.yaml

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://docs.together.ai/openapi.yaml
autosdk generate openapi.yaml \
  --namespace Together \
  --clientClassName TogetherClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
