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
      <div className="flex flex-col items-center m-5">
        <div className="w-2/5">
          <div className="bg-gray-600 rounded-t-xl">
            <h1 className="text-gray-200 font-bold p-2 flex flex-col items-center">
              Todo List
            </h1>
          </div>
          <div className="bg-lime-200 p-4 rounded-b-xl min-h-24">
            <form>
              <div className="flex flex-row gap-5">
                <div className="flex-grow">
                  <input className="w-full mb-5 h-8 p-2 rounded-md"></input>
                </div>
                <div>
                  <button className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-1 px-4 rounded">
                    Add
                  </button>
                </div>
              </div>
            </form>
            {renderItems()}
          </div>
        </div>
      </div>
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
