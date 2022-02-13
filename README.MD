# Docker Demo Project

## Setup Demo Project
### Clone Repository
```sh
git clone -b main https://github.com/filipe11402/products-core.git
```

### Publish the App in release configuration
```sh
dotnet publish -c release
```
### Create the Docker image
```sh
docker build -t image-name-desired -f Dockerfile
```
### Create Docker image instance(Container)
```sh
docker create -p 6000:80 --name docker-container-image docker-image-name
```
### Run Docker container
```sh
docker container start docker-container-name
```
### Stop Docker container
```sh
docker container stop docker-container-name
```
---
## Documentation

[Docker Registry](https://hub.docker.com/repository/docker/fencarnacao/demo-product-core)

### Dockerfile
- [Here](https://github.com/filipe11402/products-core/blob/main/Dockerfile)

## References
- [Docker Docs](https://docs.docker.com/get-started/)
- [Microsoft Docs](https://docs.microsoft.com/en-us/visualstudio/docker/tutorials/docker-tutorial)

## Changelog
- [Here](https://github.com/filipe11402/demo-docker-core/commits/main)
