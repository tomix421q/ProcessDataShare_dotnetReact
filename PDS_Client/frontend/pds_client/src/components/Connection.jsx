import { useEffect, useState } from 'react'
import ConnectionCard from './helpComponents/ConnectionCard'

// eslint-disable-next-line react/prop-types
const Connection = ({ data }) => {
  const [eqcDataList, setEqcDataList] = useState([])

  useEffect(() => {
    setEqcDataList(data)
  }, [data])

  return (
    <div className='section mx-auto'>
      <div className=' w-full flex flex-wrap gap-8 justify-center mx-6 uppercase'>
        <ConnectionCard
          name={'EQC Middlefield 1'}
          ip={'10.184.159.173'}
          connection={eqcDataList.connectionEqcMF1}
          route={'/Machinesinfo/Eqc1Live'}
        />
        <ConnectionCard
          name={'EQC Middlefield 2'}
          ip={'10.184.159.174'}
          connection={eqcDataList.connectionEqcMF2}
          route={'/Machinesinfo/Eqc2Live'}
        />
        <ConnectionCard
          name={'EQC Middlefield 3'}
          ip={'10.184.159.175'}
          connection={eqcDataList.connectionEqcMF3}
          route={'/Machinesinfo/Eqc3Live'}
        />
        <ConnectionCard
          name={'EQC Middlefield 4'}
          ip={'10.184.159.176'}
          connection={eqcDataList.connectionEqcMF4}
          route={'/Machinesinfo/Eqc4Live'}
        />
        <ConnectionCard
          name={'EQC Middlefield 5'}
          ip={'10.184.159.89'}
          connection={eqcDataList.connectionEqcMF5}
          route={'/Machinesinfo/Eqc5Live'}
        />
        <ConnectionCard
          name={'EQC Middlefield 6'}
          ip={'10.184.159.99'}
          connection={eqcDataList.connectionEqcMF6}
          route={'/Machinesinfo/Eqc6Live'}
        />
        <ConnectionCard
          name={'EQC Middlefield 7'}
          ip={'10.184.159.171'}
          connection={eqcDataList.connectionEqcMF7}
          route={'/Machinesinfo/Eqc7Live'}
        />
        <ConnectionCard
          name={'EQC Middlefield 8'}
          ip={'10.184.159.101'}
          connection={eqcDataList.connectionEqcMF8}
          route={'/Machinesinfo/Eqc8Live'}
        />
        <ConnectionCard
          name={'Asq 2'}
          ip={'10.184.159.109'}
          connection={eqcDataList.connectionAsq2}
          route={'/Machinesinfo/Asq2Live'}
        />
        <ConnectionCard
          name={'Asq 3'}
          ip={'10.184.159.240'}
          connection={eqcDataList.connectionAsq3}
          route={'/Machinesinfo/Asq3Live'}
        />
        <ConnectionCard
          name={'Asq 4'}
          ip={'10.184.159.12'}
          connection={eqcDataList.connectionAsq4}
          route={'/Machinesinfo/Asq4Live'}
        />
        <ConnectionCard
          name={'Asq 5'}
          ip={'10.184.159.108'}
          connection={eqcDataList.connectionAsq5}
          route={'/Machinesinfo/Asq5Live'}
        />
        <ConnectionCard
          name={'Asq 6'}
          ip={'10.184.159.184'}
          connection={eqcDataList.connectionEqcMF6}
          route={'/Machinesinfo/Asq6Live'}
        />
        <ConnectionCard
          name={'Opel Armrest FR'}
          ip={'10.184.159.45'}
          connection={eqcDataList.connectionOpelArmrestFd}
          route={'/Machinesinfo/OpelArmrestFront'}
        />
        <ConnectionCard
          name={'Opel Armrest RR'}
          ip={'10.184.159.46'}
          connection={eqcDataList.connectionOpelArmrestRd}
          route={'/Machinesinfo/OpelArmrestRear'}
        />
        <ConnectionCard
          name={'Opel Insert FR'}
          ip={'10.184.159.48'}
          connection={eqcDataList.connectionOpelInsertFd}
          route={'/Machinesinfo/OpelInsertFront'}
        />
        <ConnectionCard
          name={'Opel Insert RR'}
          ip={'10.184.159.47'}
          connection={eqcDataList.connectionOpelInsertRd}
          route={'/Machinesinfo/OpelInsertRear'}
        />
      </div>
    </div>
  )
}
export default Connection
