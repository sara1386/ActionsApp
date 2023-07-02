function calculate{

    var dropdown = document.getElementById("actionsDropdown");
    var value1 = document.getElementById("value1").value;
    var value2 = document.getElementById("value2").value;
    var action = dropdown.value;


    alert(value1, action)
    if (isNaN(value1) || isNaN(value2)) {
        alert("Please enter valid numbers for both inputs.");
    } else {
        performCalculation(value1, value2,action);
    }
    function performCalculation(var value1, var value2, var action) {
        const calcData = {
            Operator: action,
            value1: value1,
            value2: value2
        };

        fetch('api/Actions', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(data)
        })
            .then(response => {
                if (!response.ok) {
                    throw new Error('Network response was not OK');
                }
                return response.json();
            })
            .then(result => {
                document.getElementById("result").innerText = result
            })
            .catch(error => {
                alert("somthing went wrong" + error)
            });


    }

    

}