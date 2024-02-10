export async function getTodos() {
  const url = 'https://localhost:5000/todo'

  return fetch(`${url}`, {
    method: 'GET',
    headers: {
      accept: 'application/json',
    },
  }).then((res) => res.json())
}
