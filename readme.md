# Camunda Process Examples

These examples are based of from dotnet template over at:  https://github.com/sjefvanleeuwen/camunda-process-template

## Setup camunda using docker
```
docker run -d --name camunda -p 8080:8080 camunda/camunda-bpm-platform:latest
```

## Quiz example

The quiz example exposes a simple BPMN decision process which requests an external REST-API to pull in quiz data and then checks the answer in the json data using Javascript (script shipped into the camunda engine, see resources directory).

The javascript returns the boolean true/false based on a regex search pattern in the data.

### Running the sample

```
dotnet run

 __      __.___  ________________     _____ .______________
/  \    /  |   |/  _____/\_____  \   /  |  ||   \__    ___/
\   \/\/   |   /   \  ___ /   |   \ /   |  ||   | |    |
 \        /|   \    \_\  /    |    /    ^   |   | |    |
  \__/\  / |___|\______  \_______  \____   ||___| |____|
       \/              \/        \/     |__|

quiz camunda processes

Deploying models and start External Task Workers.

PRESS Ctrl-C TO STOP WORKERS.


Adding resource to deployment: quiz.resources.parseAnswer.js
Adding resource to deployment: quiz.resources.quiz.bpmn
Deployment to Camunda BPM succeeded.
```

![quiz bpmn diagram](.doc/quiz.bpmn.png)