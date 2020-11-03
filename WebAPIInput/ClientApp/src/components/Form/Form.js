import React, { useState } from 'react';
import { addNumber } from '../../services/InputNumber';

export const Form = () => {

    const [numberInput, setNumberInput] = useState("");
    
    const handleChange = event => {
        setNumberInput(event.target.value);
    }

    function isValidInput() {
        
        let input = document.getElementById("number").value;
        let regexPatternToValidate = /^-?\d+\.?\d*$/;

        if (!regexPatternToValidate.test(input)) {
            window.alert("Please enter a number. (Example: 12)");
            document.getElementById("number").focus();
            return false;
        }

        return true;
    }

    const handleFormSubmit = async event => {
        event.preventDefault();

        const data = {
            num: numberInput
        }

        if (isValidInput()) {
            await addNumber(data);
        }
    }

    return(
        <div>
            <div id='number-form'>
                <h3 className='h3'>Add a new number to the Database.</h3>
            </div>
            <div id='instructions'>
                <p><b>Instructions:</b> you should enter a single numeric value (integer or decimal) and <b>click submit</b>. Example: 12.156</p>
            </div>
            <div>
                <form id='form' onSubmit={handleFormSubmit}>
                    <div>
                        <label htmlFor="number">Number to insert:</label>
                        <input id='number' type='text' name='number' value={numberInput.value} onChange={handleChange}/>
                    </div>
                    <button id='submit' type='submit'>Submit</button>
                </form>
            </div>
        </div>
    )
}