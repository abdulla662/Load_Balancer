
# Load Balancer Demo using ASP.NET Core

This project demonstrates a simple custom load balancer using round-robin logic.

## 🔧 What it does
- Receives requests on the `LoadBalancerApi`
- Forwards them to one of three backend APIs (`BackendApi1`, `BackendApi2`, `BackendApi3`)
- Returns the response from the selected backend

## 🚀 How to run
1. Run `BackendApi1` on port 5001
2. Run `BackendApi2` on port 5002
3. Run `BackendApi3` on port 5003
4. Run `LoadBalancerApi` on port 7273
5. Call `http://localhost:7273/api/LoadBalancer/forward`

Each call will route to the next server in rotation.

## 📸 Screenshot
(Add Postman screenshot or sample curl request and response)
