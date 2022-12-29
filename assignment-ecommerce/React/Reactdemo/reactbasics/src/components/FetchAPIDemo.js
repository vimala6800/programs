import React, { useState, useEffect } from 'react'
export const FetchApiDemo = () => {
    const [todos, setTodos] = useState([])
    useEffect(() => {
        console.log('useEffect')
        fetch("https://jsonplaceholder.typicode.com/todos")
            .then(response => response.json())
            //      .then(json=>console.log(json))
            .then(json => setTodos(json))
    }, [])

    const rowdata = todos.map((todo) =>
        <tr key={todo.id}>
            <td>{todo.userId}</td>
            <th>{todo.id}</th>
            <th>{todo.title}</th>
            <th>{String(todo.completed)}</th>

        </tr>
    );


    return (
        <div class="container">
            <h1>
                Number of Todos {todos.length}
            </h1>
            <table class="table">
                <thead class="thead-dark">
                    <tr>
                        <td>User Id</td>
                        <td>Id</td>
                        <td>Title</td>
                        <td>Completed</td>
                    </tr>
                </thead>
                <tbody>
                    {rowdata}
                </tbody>
            </table>
        </div>
    )
}