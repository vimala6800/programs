import React, { useState } from 'react'
export const SimpleInterest = () => {
    const [principle, setPrinciple] = useState()
    const [rate, setRate] = useState()
    const [time, setTime] = useState()
    const [si, setSi] = useState()
    const calculateInterest = () => {
        let simpleInterest = (parseFloat(principle) * parseFloat(rate) * parseFloat(time)) / 100
        setSi(simpleInterest)
    }
    return (
        <div>
            <input value={principle} onChange={(e) => { setPrinciple(e.target.value) }} placeholder="principle" />
            <input value={rate} onChange={(e) => { setRate(e.target.value) }} placeholder="rate" />
            <input value={time} onChange={(e) => { setTime(e.target.value) }} placeholder="time" />
            <button onClick={calculateInterest}>Calculate</button>
            <h1> Simple Interest is {si}</h1>
            </div>
        )
}