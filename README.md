# Using Configmaps in K8s - example .net 6

Note that the appsettings.json file is in its own folder in the VS solution.  This is necessary as a k8s configmap is mounted to a directory and wipes out any files in that directory at creation time.

## Steps

Build app in VS.
Dockerise the app.
Push to Dockerhub.
Create deployment and configmap in k8s.

### Containerise a .net app
https://docs.microsoft.com/en-us/dotnet/core/docker/build-container?tabs=windows

### General configmap docs
https://kubernetes.io/docs/concepts/configuration/configmap/