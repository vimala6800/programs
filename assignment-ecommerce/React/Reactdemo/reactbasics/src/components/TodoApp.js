import React, { useState } from "react";
import "./TodoApp.css";
const TodoApp = () => {
    document.title = 'Simple Todo list exmple';
    const [todoItem, setTodoItem] = useState("");
    const [todoList, setTodoList] = useState([
        { id: 1, text: "learn about react" },
        { id: 2, text: "meet my friend fro lunch" },
        { id: 3, text: "build really cool todo app" }
    ]);
    const geneterateId = () => {
        const highestId = Math.max.apply(Math, todoList.map(function (element) {
            return element.id;
        }));
        let newId = 1;
        if (highestId > 0) {
            newId = (highestId + 1);
        }
        return newId;
    };
    function createNewToDoItem() {
        if (todoItem !== '') {
            const item = { id: geneterateId(), text: todoItem };
            const tempArray = [...todoList, item];
            setTodoList(tempArray);
        }
        setTodoItem('');
    }
    function handleAdd(e) {
        e.preventDefault();
        createNewToDoItem();
    }
    const handlekeyPress = e => {
        if (e.key == 'Enter') {
            createNewToDoItem();
        }
    };
    const deleteItem = id => {
        setTodoList(todoList.filter(item => item.id !== id));

    };
    const display = todoList.map(item => (
        <li key={item.id} onClick={() => deleteItem(item.id)}>
            {item.text}
        </li>
    ));
    return (
        <div calssName="container mt-5 col-8">
            <h3>Simple todo List-{display.length}</h3>
            <div className="input-group">
                <input
                    type="text"
                    name="todoItem"
                    value={todoItem}
                    onChange={e => {
                        setTodoItem(e.currentTarget.value);
                    }}
                    onKeyPress={handlekeyPress}
                    className="form-control"
                />
                <div className="input-group-append">
                    <button type="button" onClick={handleAdd} className="btn btn-primary">
                        Add todo
                    </button>
                    
                </div>
            </div>
            <ul>{display}</ul>
        </div>
        );
}
export default TodoApp
