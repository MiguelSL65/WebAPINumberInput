import React, { useState } from 'react';
import axios from 'axios';
import './Style.css';

export const SumForm = () => {

    const [idList, setIdList] = useState("");
    const [result, setResult] = useState("");
    
    function isValidInput() {
        
        let input = document.getElementById("number").value;
        let regexPatternToValidate = /^\d+( \d+)*$/;

        if (!regexPatternToValidate.test(input)) {
            window.alert("Please enter space separeted values. (Example: 1 2 12)");
            document.getElementById("number").focus();
            return false;
        }

        return true;
    }

    const handleChange = event => {
        setIdList(event.target.value);
    }

    const handleFormSubmit = async event => {
        event.preventDefault();

        let listOfNumbers = {
            indexes: idList.split(" ")
        }

        if(isValidInput()) {
            await axios.post("https://localhost:44397/api/sum", listOfNumbers)
                .then(response => {
                    console.log(response.data);
                    setResult(response.data);
                })
                .catch(error => {
                    console.log(error);
                    setResult("error");
                });
        }
    }

    return (
        <div id='form'>
            <div id='number-form'>
                <h3 className='h3'>Add a list of indexes and get the sum of the values.</h3>
            </div>
            <div id='instructions'>
                <p><b>Instructions:</b> you should enter a space separeted list of numbers and <b>click submit</b>. Example: 1 2 5</p>
                <p>Please pay attention that you have entered enough values in the database.</p>
            </div>
            <div>
                <form id='form2' onSubmit={handleFormSubmit}>
                    <div id='list-of-in'>
                        <label htmlFor="number">List of indexes:</label>
                        <input id='number' type='text' name='number' value={idList} onChange={handleChange}/>
                    </div>
                    <div id="resultDiv">
                        <p id="result">Result: {result}</p>
                    </div>
                    <button id='submit' type='submit'>Submit</button>
                </form>
            </div>
        </div>
    )
}