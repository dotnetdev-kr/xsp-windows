# XSP for Windows Container

## Introduction

The XSP server is a small web server that hosts the Mono System.Web classes for running what is commonly known as ASP.NET.

This version of code is a modified version so that xsp can run on .NET Framework instead of Mono runtime, and at the same time this is a modified version that can be run on a Windows container.

This is the fork version of [mono/xsp](https://github.com/mono/xsp).

## How can I use this tool

- Install the latest version of Docker Desktop for Windows - or - Docker Engine for Windows Container
- Checkout the repository and build the XSP Windows Container into your local Docker instance
- Build your own IIS/ASP.NET web application container with the XSP Windows Container image.
