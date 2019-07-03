# RabbitMQ for DotNet Developers

   - You need Erlang to run RabbitMQ, go here [erlang](https://www.erlang.org/downloads)
   - You would also need RabbitMQ Server, download and install here [RabbitMQ](https://www.rabbitmq.com/download.html)
   - You can go to this [RabbitMQ tutorials](https://www.rabbitmq.com/getstarted.html) to see the whole tutorial


## Set Environment Variables

| VARIABLE | VALUE |
| ------ | ------ |
| ERLANG_HOME | C:\Program Files\erl10.4 |
| RABBITMQ_NODENAME | rabbit@localhost |
| RABBITMQ_SERVER | C:\Program Files\RabbitMQ Server\rabbitmq_server-3.7.15 |
| PATH | %RABBITMQ_SERVER%\sbin |

## Run RabbitMQ
    - To run a project, go to each directory/project and run

```sh
$ dotnet run
```


### RabbitMQ Admin

```sh
$ rabbitmq-plugins enable rabbitmq_management
```
    - the go to RabbitMQ admin page http://localhost:15672/
    - username: guest
    - password: guest



