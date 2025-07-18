import { useEffect, useState } from 'react'
import './App.css'
import { Button } from '@mantine/core'
import type { SolarPanel } from './model/SolarPanel';

function App() {
  const get_panels = async () => {
    const response = await fetch("https://localhost:7118/api/Panel/all");
    const result = await response.json();

    setPanels(result)
  };

  useEffect(() => {get_panels()}, [])

  const [panels, setPanels] = useState<SolarPanel[]>([]);

  return (
    <>
      <Button>Bok</Button>
      {
        panels.map((x)=><div>{x.name}</div>)
      }
    </>
  )
}

export default App