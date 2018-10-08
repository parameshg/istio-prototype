# Northwind Microservices and Service Mesh

[![Gitter chat](https://badges.gitter.im/gitterHQ/gitter.png)](https://gitter.im/parameshg/istio)

## Introduction
This project is a prototype implementation of service mesh using istio on kubernetes cluster.

## Context
This protoype allows customers to be able to browse products and submit orders from a location along with payment details. The system validates supported region and credit card issues. This prototype is structured in a way that features are progressively released in subsequent versions. The system contains the following services:
* Product Service: Provides apis to search products
* Order Service: Provides apis to submit orders
* Payment Service: Facilitates validation of credit card details
* Address Service: Facilitates address validation

The storyline is as follows: On product launch, v1, the service is limited to central and northern Sydney area and accepts payment via Mastercard and Visa credit cards only. As the product gains traction, in v2, the service area is expaned to western Sydney accepting a wide range of credit cards. A bug has been found in address service where a few postal code has been missed (For example, 2145) during validation. Hence, a hotfix (v3) for address service has been released.

## Demo Features
This prototype aims to demonstrate the following features of Istio Service Mesh.
* Blue-Green Deployment
* Canary Release
* Fault Injection

## Demo User Interfaces

![Installation and Configuration](https://raw.githubusercontent.com/parameshg/northwind-mesh/master/Images/dashboard.png "Installation and Configuration")

![Features](https://raw.githubusercontent.com/parameshg/northwind-mesh/master/Images/features.png "Features")

![Transaction](https://raw.githubusercontent.com/parameshg/northwind-mesh/master/Images/transaction.png "Transaction")
