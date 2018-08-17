// fetch execution variables
var response = connector.getVariable("response");
var answer = connector.getVariable("answer");

var questions = S(response);

var query = "$..[?(@.answer=='" + answer + "')]";

!questions.jsonPath(query).elementList().isEmpty();