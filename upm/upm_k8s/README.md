kubectl apply -f deploy/deployment.yaml
kubectl apply -f svc/service.yaml
kubectl get deployments
kubectl get svc

open http://EXTERNAL-IP:4873