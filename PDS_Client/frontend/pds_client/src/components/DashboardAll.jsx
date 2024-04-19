import { useEffect, useState } from 'react'
import CardEqc from './helpComponents/CardEqc'
import DoubleCard from './helpComponents/DoubleCard'

// eslint-disable-next-line react/prop-types
const DashboardAll = ({ data }) => {
  const [eqcDataList, setEqcDataList] = useState([])

  useEffect(() => {
    setEqcDataList(data)
  }, [data])

  return (
    <div className='section '>
      <div className='max-w-[1800px] xl:max-w-full w-full mx-auto flex flex-wrap gap-x-6 gap-y-6 justify-center md:hidden'>
        <span className='block md:hidden text-primary'>Eqc machines</span>
        <div className='flex md:flex-wrap flex-row gap-6  md:justify-center mx-auto  max-sm:px-16 max-sm:snap-x max-sm:overflow-auto'>
          <CardEqc
            eqcName='EQC 1'
            connection={eqcDataList.connectionEqcMF1}
            downtime={eqcDataList.eqcMF1_actualDownTime}
            collorRibbon={'bg-blue-600'}
            route={'/Machinesinfo/Eqc1Live'}
          />

          <CardEqc
            eqcName='EQC 2'
            connection={eqcDataList.connectionEqcMF2}
            downtime={eqcDataList.eqcMF2_actualDownTime}
            collorRibbon={'bg-blue-600'}
            route={'/Machinesinfo/Eqc2Live'}
          />

          <CardEqc
            eqcName='EQC 3'
            connection={eqcDataList.connectionEqcMF3}
            downtime={eqcDataList.eqcMF3_actualDownTime}
            collorRibbon={'bg-blue-600'}
            route={'/Machinesinfo/Eqc3Live'}
          />

          <CardEqc
            eqcName='EQC 4'
            connection={eqcDataList.connectionEqcMF4}
            downtime={eqcDataList.eqcMF4_actualDownTime}
            collorRibbon={'bg-blue-600'}
            route={'/Machinesinfo/Eqc4Live'}
          />
          <CardEqc
            eqcName='EQC 5'
            connection={eqcDataList.connectionEqcMF5}
            downtime={eqcDataList.eqcMF5_actualDownTime}
            collorRibbon={'bg-blue-600'}
            route={'/Machinesinfo/Eqc5Live'}
          />
          <CardEqc
            eqcName='EQC 6'
            connection={eqcDataList.connectionEqcMF6}
            downtime={eqcDataList.eqcMF6_actualDownTime}
            collorRibbon={'bg-blue-600'}
            route={'/Machinesinfo/Eqc6Live'}
          />
          <CardEqc
            eqcName='EQC 7'
            connection={eqcDataList.connectionEqcMF7}
            downtime={eqcDataList.eqcMF7_actualDownTime}
            collorRibbon={'bg-blue-600'}
            route={'/Machinesinfo/Eqc7Live'}
          />
          <CardEqc
            eqcName='EQC 8'
            connection={eqcDataList.connectionEqcMF8}
            downtime={eqcDataList.eqcMF8_actualDownTime}
            collorRibbon={'bg-blue-600'}
            route={'/Machinesinfo/Eqc8Live'}
          />
        </div>
        <span className='block md:hidden text-primary'>Opel machines</span>
        <div className='flex md:flex-wrap flex-row gap-6  md:justify-center mx-auto  max-sm:px-16 max-sm:snap-x max-sm:overflow-auto'>
          <CardEqc
            eqcName='Opel Insert FD'
            connection={eqcDataList.connectionOpelInsertFd}
            downtime={eqcDataList.opelInsertFD_actualDowntime}
            collorRibbon={'bg-yellow-500'}
            route={'/Machinesinfo/OpelInsertFront'}
          />
          <CardEqc
            eqcName='Opel Insert RD'
            connection={eqcDataList.connectionOpelInsertRd}
            downtime={eqcDataList.opelInsertRD_actualDowntime}
            collorRibbon={'bg-yellow-500'}
            route={'/Machinesinfo/OpelInsertRear'}
          />
          <CardEqc
            eqcName='Opel Armrest FD'
            connection={eqcDataList.connectionOpelArmrestFd}
            downtime={eqcDataList.opelArmrestFD_actualDowntime}
            collorRibbon={'bg-yellow-500'}
            route={'/Machinesinfo/OpelArmrestFront'}
          />
          <CardEqc
            eqcName='Opel Armrest RD'
            connection={eqcDataList.connectionOpelArmrestRd}
            downtime={eqcDataList.opelArmrestRD_actualDowntime}
            collorRibbon={'bg-yellow-500'}
            route={'/Machinesinfo/OpelArmrestRear'}
          />
        </div>

        {/* ASQ */}
        <span className='block md:hidden text-primary'>Asq machines</span>
        <div className='flex md:flex-wrap flex-row gap-6  md:justify-center mx-auto w-full max-sm:px-16 max-sm:snap-x max-sm:overflow-auto'>
          <DoubleCard
            name='Asq_2'
            connection={eqcDataList.connectionAsq2}
            downtimeA={eqcDataList.asQ_2_ROB1_Downtime_Time}
            downtimeB={eqcDataList.asQ_2_ROB2_Downtime_Time}
            collorRibbon={'bg-purple-500'}
            route={'/Machinesinfo/Asq2Live'}
          />
          <DoubleCard
            name='Asq_3'
            connection={eqcDataList.connectionAsq3}
            downtimeA={eqcDataList.asQ_3_ROB1_Downtime_Time}
            downtimeB={eqcDataList.asQ_3_ROB2_Downtime_Time}
            collorRibbon={'bg-purple-500'}
            route={'/Machinesinfo/Asq3Live'}
          />
          <DoubleCard
            name='Asq_4'
            connection={eqcDataList.connectionAsq4}
            downtimeA={eqcDataList.asQ_4_ROB1_Downtime_Time}
            downtimeB={eqcDataList.asQ_4_ROB2_Downtime_Time}
            collorRibbon={'bg-purple-500'}
            route={'/Machinesinfo/Asq4Live'}
          />
          <DoubleCard
            name='Asq_5'
            connection={eqcDataList.connectionAsq5}
            downtimeA={eqcDataList.asQ_5_ROB1_Downtime_Time}
            downtimeB={eqcDataList.asQ_5_ROB2_Downtime_Time}
            collorRibbon={'bg-purple-500'}
            route={'/Machinesinfo/Asq5Live'}
          />
          <DoubleCard
            name='Asq_6'
            connection={eqcDataList.connectionAsq6}
            downtimeA={eqcDataList.asQ_6_ROB1_Downtime_Time}
            downtimeB={eqcDataList.asQ_6_ROB2_Downtime_Time}
            collorRibbon={'bg-purple-500'}
            route={'/Machinesinfo/Asq6Live'}
          />
        </div>
      </div>

      {/* desktop  */}
      <div className='max-w-[1800px] xl:max-w-full w-full mx-auto hidden md:flex flex-wrap gap-x-6 gap-y-6 justify-center'>
        <CardEqc
          eqcName='EQC 1'
          connection={eqcDataList.connectionEqcMF1}
          downtime={eqcDataList.eqcMF1_actualDownTime}
          collorRibbon={'bg-blue-600'}
          route={'/Machinesinfo/Eqc1Live'}
        />

        <CardEqc
          eqcName='EQC 2'
          connection={eqcDataList.connectionEqcMF2}
          downtime={eqcDataList.eqcMF2_actualDownTime}
          collorRibbon={'bg-blue-600'}
          route={'/Machinesinfo/Eqc2Live'}
        />

        <CardEqc
          eqcName='EQC 3'
          connection={eqcDataList.connectionEqcMF3}
          downtime={eqcDataList.eqcMF3_actualDownTime}
          collorRibbon={'bg-blue-600'}
          route={'/Machinesinfo/Eqc3Live'}
        />

        <CardEqc
          eqcName='EQC 4'
          connection={eqcDataList.connectionEqcMF4}
          downtime={eqcDataList.eqcMF4_actualDownTime}
          collorRibbon={'bg-blue-600'}
          route={'/Machinesinfo/Eqc4Live'}
        />
        <CardEqc
          eqcName='EQC 5'
          connection={eqcDataList.connectionEqcMF5}
          downtime={eqcDataList.eqcMF5_actualDownTime}
          collorRibbon={'bg-blue-600'}
          route={'/Machinesinfo/Eqc5Live'}
        />
        <CardEqc
          eqcName='EQC 6'
          connection={eqcDataList.connectionEqcMF6}
          downtime={eqcDataList.eqcMF6_actualDownTime}
          collorRibbon={'bg-blue-600'}
          route={'/Machinesinfo/Eqc6Live'}
        />
        <CardEqc
          eqcName='EQC 7'
          connection={eqcDataList.connectionEqcMF7}
          downtime={eqcDataList.eqcMF7_actualDownTime}
          collorRibbon={'bg-blue-600'}
          route={'/Machinesinfo/Eqc7Live'}
        />
        <CardEqc
          eqcName='EQC 8'
          connection={eqcDataList.connectionEqcMF8}
          downtime={eqcDataList.eqcMF8_actualDownTime}
          collorRibbon={'bg-blue-600'}
          route={'/Machinesinfo/Eqc8Live'}
        />

        <CardEqc
          eqcName='Opel Insert FD'
          connection={eqcDataList.connectionOpelInsertFd}
          downtime={eqcDataList.opelInsertFD_actualDowntime}
          collorRibbon={'bg-yellow-500'}
          route={'/Machinesinfo/OpelInsertFront'}
        />
        <CardEqc
          eqcName='Opel Insert RD'
          connection={eqcDataList.connectionOpelInsertRd}
          downtime={eqcDataList.opelInsertRD_actualDowntime}
          collorRibbon={'bg-yellow-500'}
          route={'/Machinesinfo/OpelInsertRear'}
        />
        <CardEqc
          eqcName='Opel Armrest FD'
          connection={eqcDataList.connectionOpelArmrestFd}
          downtime={eqcDataList.opelArmrestFD_actualDowntime}
          collorRibbon={'bg-yellow-500'}
          route={'/Machinesinfo/OpelArmrestFront'}
        />
        <CardEqc
          eqcName='Opel Armrest RD'
          connection={eqcDataList.connectionOpelArmrestRd}
          downtime={eqcDataList.opelArmrestRD_actualDowntime}
          collorRibbon={'bg-yellow-500'}
          route={'/Machinesinfo/OpelArmrestRear'}
        />

        {/* ASQ */}

        <DoubleCard
          name='Asq_2'
          connection={eqcDataList.connectionAsq2}
          downtimeA={eqcDataList.asQ_2_ROB1_Downtime_Time}
          downtimeB={eqcDataList.asQ_2_ROB2_Downtime_Time}
          collorRibbon={'bg-purple-500'}
          route={'/Machinesinfo/Asq2Live'}
        />
        <DoubleCard
          name='Asq_3'
          connection={eqcDataList.connectionAsq3}
          downtimeA={eqcDataList.asQ_3_ROB1_Downtime_Time}
          downtimeB={eqcDataList.asQ_3_ROB2_Downtime_Time}
          collorRibbon={'bg-purple-500'}
          route={'/Machinesinfo/Asq3Live'}
        />
        <DoubleCard
          name='Asq_4'
          connection={eqcDataList.connectionAsq4}
          downtimeA={eqcDataList.asQ_4_ROB1_Downtime_Time}
          downtimeB={eqcDataList.asQ_4_ROB2_Downtime_Time}
          collorRibbon={'bg-purple-500'}
          route={'/Machinesinfo/Asq4Live'}
        />
        <DoubleCard
          name='Asq_5'
          connection={eqcDataList.connectionAsq5}
          downtimeA={eqcDataList.asQ_5_ROB1_Downtime_Time}
          downtimeB={eqcDataList.asQ_5_ROB2_Downtime_Time}
          collorRibbon={'bg-purple-500'}
          route={'/Machinesinfo/Asq5Live'}
        />
        <DoubleCard
          name='Asq_6'
          connection={eqcDataList.connectionAsq6}
          downtimeA={eqcDataList.asQ_6_ROB1_Downtime_Time}
          downtimeB={eqcDataList.asQ_6_ROB2_Downtime_Time}
          collorRibbon={'bg-purple-500'}
          route={'/Machinesinfo/Asq6Live'}
        />
      </div>
    </div>
  )
}
export default DashboardAll
