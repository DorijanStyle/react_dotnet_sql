import './App.css'
import { Button, Flex, Group } from '@mantine/core'
import ListComponent from './components/ListComponent'

function App() {
  return (
    <>

      <Flex style={{width: "100%", height: "100%"}} justify={"space-between"}>
        <ListComponent>
          
        </ListComponent>

        <Button>Bok</Button>
      </Flex>

    </>
  )
}

export default App