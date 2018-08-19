# Camunda Process Examples

These examples are based of from dotnet template over at:  https://github.com/sjefvanleeuwen/camunda-process-template

## Setup camunda using docker
```
docker run -d --name camunda -p 8080:8080 camunda/camunda-bpm-platform:latest
```

You can model processes using camunda modeler available at: https://camunda.com/download/modeler/

## Available Samples
1. [Quiz example](quiz/readme.md)
2. [Simple DMN Sample](basic-dmn/readme.md)
3. Discount ordering process (under construction)

## Built With

* [VSCODE](https://code.visualstudio.com/) - The IDE used
* [DOCKER](https://www.docker.com/) - Build, Ship, and Run Any App, Anywhere
* [CAMUNDA](https://www.camunda.com) - Open source platform for workflow and decision automation that brings business users and software developers together.

## Contributing

Pull requests are accepted

## Authors

* **Sjef van Leeuwen** - *Initial work* - [github](https://github.com/sjefvanleeuwen)

## License

This project is licensed under the GPL-V3 License - see the [LICENSE.md](LICENSE.md) file for details