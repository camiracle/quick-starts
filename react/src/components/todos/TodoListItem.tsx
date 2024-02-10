export default function TodoListItem({ item }: Props) {
  return (
    <div>
      {item.description}
      {renderChecked(item.isComplete)}
    </div>
  )

  function renderChecked(isComplete: boolean) {
    return isComplete ? <span>✔</span> : <></>
  }
}

interface Props {
  item: { description: string; isComplete: boolean }
}
