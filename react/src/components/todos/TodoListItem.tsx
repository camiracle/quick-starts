export default function TodoListItem({ item }: Props) {
  return <div>{item.description}</div>
}

interface Props {
  item: { description: string }
}
