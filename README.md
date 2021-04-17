# redis-pub-sub

Run Docker Container

```
docker run --name my-redis -p 6379:6379 -d redis
```

Run Subscriber
```
cd redis-subscriber && dotnet run
```

Run Publisher
```
cd redis-publisher && dotnet run
```
