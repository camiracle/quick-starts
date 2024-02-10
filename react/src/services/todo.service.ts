export async function getTodos() {
  const url = `${import.meta.env.VITE_API_URL}/todo`

  import.meta.env.VITE_API_URL

  return fetch(`${url}`, {
    method: 'GET',
    headers: {
      accept: 'application/json',
    },
  }).then((res) => res.json())
}
