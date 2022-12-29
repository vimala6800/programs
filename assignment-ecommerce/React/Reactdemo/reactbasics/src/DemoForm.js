import React, { useState } from 'react'
export const DemoForm = () => {
    const [name, setName] = useState('vimala')
    const handleChange = (s) => {
        console.log(s.target.value)
        setName(s.target.value)
    }
    return (
        <div>
            <form>
            <input value={name} onChange={handleChange} />
                <h1>your name is {name}</h1>
            </form>
        </div>
        )

}