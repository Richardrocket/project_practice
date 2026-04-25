# AI Agent Guidance for This Workspace

## Current workspace state
- The repository currently contains no source files, configuration, or documentation.
- There are no detected build/test commands or project-specific conventions to follow.

## What agents should do
- Do not make assumptions about the project type, language, or framework.
- Ask the user for the intended project purpose before generating scaffolding or implementing features.
- When new files appear, inspect top-level manifests such as `package.json`, `pyproject.toml`, `pom.xml`, `README.md`, or `.csproj` to infer project type.

## When adding content
- Keep guidance minimal and link to project documentation once it exists.
- Prefer creating new files under a clear structure rather than modifying unknown layouts.
- If the user asks to scaffold a project, first confirm the target language/framework and preferred tooling.

## Recommended next customization files
- `README.md` or project documentation if the user adds a new codebase.
- `.github/copilot-instructions.md` if the repo later needs more detailed AI behavior rules.
- Skills for common workflows once a project type is established.
