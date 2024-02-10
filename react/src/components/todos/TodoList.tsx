import { useEffect, useState } from 'react'
import { getTodos } from '../../services/todo.service'
import TodoListItem from './TodoListItem'

export default function TodoList() {
  const [todos, setTodos] = useState([])

  // TODO: setup Zustand and make service calls from store, or something

  useEffect(() => {
    getTodos().then((t) => {
      setTodos(t)
    })
  }, [])

  return (
    <>
      <h1>Todo List</h1>
      {renderItems()}
    </>
  )

  function renderItems() {
    return (
      <ul>
        {todos.map((t, i) => (
          <li key={i + 'item'}>
            <TodoListItem item={t}></TodoListItem>
          </li>
        ))}
      </ul>
    )
  }
}
