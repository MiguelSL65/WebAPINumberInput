import React, { useState, useEffect } from 'react';
import { getAll } from '../../services/InputNumber';
import './NumStyle.css';

export const NumTable = () => {

    const [numbers, setNumbers] = useState([]);

    useEffect(() => {
        const getNumbers = async () => {
            setNumbers(await getAll())
        }

        getNumbers();

    }, []);

    if (!numbers) {
        return <div>Loading...</div>
    }

    return(
        <div>
            {numbers.map(num => (
                <div key={num.id} id='numlist'>
                    <div>{`Id: ${num.id}`}</div>
                    <div>{`Number: ${num.num}`}</div>
                </div>
            ))}
        </div>
    )
}