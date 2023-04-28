FROM mcr.microsoft.com/vscode/devcontainers/dotnet:6.0

# Install redis-cli 
RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
    && apt-get -y install --no-install-recommends redis-tools
