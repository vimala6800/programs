import React, { Component } from "react"

export default class ClassComponent extends Component {
    constructor(props) {
        super(props)
        console.log('props ', props);
    }
    render() {
        return (
            <div>
                <h1>Class Component</h1>
                <h2> Name : {this.props.course.name}</h2>
            </div>
        )
    }
}