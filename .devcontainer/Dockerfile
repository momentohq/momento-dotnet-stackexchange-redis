FROM mcr.microsoft.com/vscode/devcontainers/dotnet:6.0

# Install redis-cli and mono (for .NET Framework)
RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
    && apt-get -y install --no-install-recommends redis-tools mono-runtime
