import React from 'react'

const Content = () => {
    const course = "DOTNETCOREMVC"
    const wishlist = ['java fullstack', 'DOTNETCOREMVC', 'Blockchain']
    const emp = { code: 1, name: 'vimala', dept: 'IT', desg: 'SE' }
    return (
        <div>
            <h1>I am learning - {course}</h1>
            <h1> My wish list - {wishlist}</h1>
            <h2>My details - Code : {emp.code} - Name :{emp.name} </h2>
        </div>
    )
}

export default Content