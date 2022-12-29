import logo from './logo.svg';
import './App.css';
import { SimpleInterest } from './SimpleInterest';
import { DemoForm } from './DemoForm';
import Header from './Header';
import Content from './Content';
import ClassComponent from './components/ClassComponent';
import { ClassComponentState } from './components/ClassComponentState';
import { FetchApiDemo } from './components/FetchAPIDemo';
import TodoApp from './components/TodoApp';
import AssignmentReact from './components/AssignmentReact';
function App() {

    const emp = {
        id: 1,
        name: 'vimala',
        course: 'react',
        duration: '15days'

    }


    return (
        <div className="App">
            <h1> welcome to react</h1>
            <Header />
            <Content />
            <DemoForm />
            <SimpleInterest />
            <ClassComponent course={emp} />
            <ClassComponentState />
            <FetchApiDemo></FetchApiDemo>}
<TodoApp></TodoApp>
<AssignmentReact></AssignmentReact>
        </div>
    );
}

export default App;