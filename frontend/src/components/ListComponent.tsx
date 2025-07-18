import type React from "react"
import { useEffect, useState } from "react";
import type { SolarPanel } from "../model/SolarPanel";

import styles from "./ListComponent.module.css";
import { FaRegTrashCan } from "react-icons/fa6";
import { PiSolarPanelLight } from "react-icons/pi";
import { Box, Button, Input } from "@mantine/core";

// https://react-icons.github.io/react-icons/search/#q=trash

interface Props 
{
    style?: React.CSSProperties;
}

export default function ListComponent(props : Props)
{
    const get_panels = async () => {
        const response = await fetch("https://localhost:7118/api/Panel/all");
        const result = await response.json();
    
        setPanels(result)
      };
    
      useEffect(() => {get_panels()}, [])
    
      const [panels, setPanels] = useState<SolarPanel[]>([]);

    return (
    <>
        <div className={styles.navbar}>
            <div className={styles.navbarTitle}>
                <span><PiSolarPanelLight/></span>
                <span>Solar Panel Website</span>
                <Input></Input>
                {/* <Button>Add</Button> */}
            </div>
            <div style={{maxHeight: "100%", overflowY:"scroll", paddingRight: "5px"}}>
            {

                panels.map((x)=><Box className={styles.item}>
                    <span>{x.name}</span>
                    <Button variant="subtle" className={styles.button}><FaRegTrashCan/></Button>
                </Box>)
            }
            </div>
        </div>
    </>);
}