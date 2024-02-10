export async function getTodos() {
  const url = `${import.meta.env.TODO_API_URL}/todo`

  return fetch(`${url}`, {
    method: 'GET',
    headers: {
      accept: 'application/json',
    },
  }).then((res) => res.json())
}
