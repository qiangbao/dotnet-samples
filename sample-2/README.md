# Instructions

Create a web service with the following endpoint. You may use any web framework you are comfortable with. You 
will also need to setup a local Mongo database. You can develop in Visual Studio or Xamarin Studio.

------

`http://localhost:8080/pangrams`

(The hostname and port are not important - you may use whatever is easiest to set up).

This endpoint should accept a POST request with a parameter named "sentence". It must return a JSON object response of the following format:

    {
        "isPangram": [true / false]
    }

If the sentence is a pangram, you must save it to a collection called "pangrams".

The same endpoint should also accept a GET request and a query parameter named "limit", and return a JSON array response
containing a list of every pangram sentence that has been POSTed to the endpoint, limited by the "limit" query
parameter.

`http://localhost:8080/pangrams?limit=5`

    {
        "pangrams": [
            "The quick brown dog jumps over the lazy dog",
            "A wizard's job is to quickly vex chumps in fog",
            "Pack my box with five dozen liquor jugs",
            "Sphinx of black quartz, judge my vow.",
            "Waltz, nymph, for quick jigs vex Bud."
        ]
    }

