export async function getTodos() {
  const url = 'https://localhost:5000/todo'

  return fetch(`${url}`, {
    method: 'GET',
    headers: {
      Accept: 'application/json',
      'Content-Type': 'application/json',
    },
  }).then((res) => res.json())
}
