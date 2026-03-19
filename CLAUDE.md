# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Together AI](https://www.together.ai/) inference platform, auto-generated from the Together OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build Together.slnx

# Build for release (also produces NuGet package)
dotnet build Together.slnx -c Release

# Run integration tests (requires TOGETHER_API_KEY env var)
dotnet test src/tests/Together.IntegrationTests/Together.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Together && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** -- do not manually edit files in `src/libs/Together/Generated/`.

1. `src/libs/Together/openapi.yaml` -- the Together OpenAPI spec (fetched from `https://raw.githubusercontent.com/togethercomputer/openapi/main/openapi.yaml`)
3. `src/libs/Together/generate.sh` -- orchestrates: download spec, fix spec, run AutoSDK CLI, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Together/` | Main SDK library (`TogetherClient`) |
| `src/tests/Together.IntegrationTests/` | Integration tests against real Together API |

### Documentation Generation

Tests in `src/tests/Together.IntegrationTests/Examples` are the single source of truth for both test coverage and documentation:
- Each file has a JSDoc header (`order`, `title`, `slug`) consumed by `autosdk docs sync .`
- Comments prefixed with `////` become prose paragraphs in generated docs
- CI workflow (`.github/workflows/mkdocs.yml`) auto-generates `docs/examples/` and populates `EXAMPLES:START/END` markers in README.md, docs/index.md, and mkdocs.yml
- Config: `autosdk.docs.json` points to `src/tests/Together.IntegrationTests/Examples`
### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + AwesomeAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
