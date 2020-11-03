import axios from 'axios';

export const addNumber = async (data) => {
    
    return await axios.post("https://localhost:44397/api/number", data)
        .then(response => {
            alert("Number added successfuly to DB!");
            document.getElementById("form").reset();
        })
        .catch(error => console.log(error));
}

export const getSum = async (listOfNumbers) => {

    return await axios.post("https://localhost:44397/api/sum", listOfNumbers)
        .then(response => response.data)
        .catch(error => console.log(error));
}