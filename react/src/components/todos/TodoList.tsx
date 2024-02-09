import { getTodos } from '../../services/todo.service'
import TodoListItem from './TodoListItem'

export default function TodoList() {
  let todos: any[] = []
  getTodos().then((t) => (todos = t))

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
